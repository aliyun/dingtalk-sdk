<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripProductConfigRequest;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripProductConfigRequest\tripProductConfigList\tmcInfos;
use AlibabaCloud\Tea\Model;

class tripProductConfigList extends Model
{
    /**
     * @var bool
     */
    public $allVisible;

    /**
     * @var string[]
     */
    public $deptVisibleScopes;

    /**
     * @var bool
     */
    public $openStatus;

    /**
     * @var string
     */
    public $productType;

    /**
     * @var string[]
     */
    public $roleVisibleScopes;

    /**
     * @var string[]
     */
    public $staffVisibleScopes;

    /**
     * @var tmcInfos[]
     */
    public $tmcInfos;
    protected $_name = [
        'allVisible'         => 'allVisible',
        'deptVisibleScopes'  => 'deptVisibleScopes',
        'openStatus'         => 'openStatus',
        'productType'        => 'productType',
        'roleVisibleScopes'  => 'roleVisibleScopes',
        'staffVisibleScopes' => 'staffVisibleScopes',
        'tmcInfos'           => 'tmcInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allVisible) {
            $res['allVisible'] = $this->allVisible;
        }
        if (null !== $this->deptVisibleScopes) {
            $res['deptVisibleScopes'] = $this->deptVisibleScopes;
        }
        if (null !== $this->openStatus) {
            $res['openStatus'] = $this->openStatus;
        }
        if (null !== $this->productType) {
            $res['productType'] = $this->productType;
        }
        if (null !== $this->roleVisibleScopes) {
            $res['roleVisibleScopes'] = $this->roleVisibleScopes;
        }
        if (null !== $this->staffVisibleScopes) {
            $res['staffVisibleScopes'] = $this->staffVisibleScopes;
        }
        if (null !== $this->tmcInfos) {
            $res['tmcInfos'] = [];
            if (null !== $this->tmcInfos && \is_array($this->tmcInfos)) {
                $n = 0;
                foreach ($this->tmcInfos as $item) {
                    $res['tmcInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tripProductConfigList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allVisible'])) {
            $model->allVisible = $map['allVisible'];
        }
        if (isset($map['deptVisibleScopes'])) {
            if (!empty($map['deptVisibleScopes'])) {
                $model->deptVisibleScopes = $map['deptVisibleScopes'];
            }
        }
        if (isset($map['openStatus'])) {
            $model->openStatus = $map['openStatus'];
        }
        if (isset($map['productType'])) {
            $model->productType = $map['productType'];
        }
        if (isset($map['roleVisibleScopes'])) {
            if (!empty($map['roleVisibleScopes'])) {
                $model->roleVisibleScopes = $map['roleVisibleScopes'];
            }
        }
        if (isset($map['staffVisibleScopes'])) {
            if (!empty($map['staffVisibleScopes'])) {
                $model->staffVisibleScopes = $map['staffVisibleScopes'];
            }
        }
        if (isset($map['tmcInfos'])) {
            if (!empty($map['tmcInfos'])) {
                $model->tmcInfos = [];
                $n               = 0;
                foreach ($map['tmcInfos'] as $item) {
                    $model->tmcInfos[$n++] = null !== $item ? tmcInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
