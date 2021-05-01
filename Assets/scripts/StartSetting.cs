using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Hide Boundary Walls at runtime
        //CoreServices.BoundarySystem.ShowBoundaryWalls = false;
        //CoreServices.BoundarySystem.ShowBoundaryCeiling = false;
        //CoreServices.BoundarySystem.ShowFloor = false;

        // Suspend Mesh Observation from all Observers
        //CoreServices.SpatialAwarenessSystem.SuspendObservers();
        // Set to visible and the Occlusion material
        // Get the first Mesh Observer available, generally we have only one registered
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Occlusion;

        //CoreServices.DiagnosticsSystem.ShowDiagnostics = false;
        //CoreServices.DiagnosticsSystem.ShowProfiler = false;
    }
}
