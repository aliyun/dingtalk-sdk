<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList\bizDataList;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList\relationPermissionDTO;
use AlibabaCloud\Tea\Model;

class relationList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bizDataList[]
     */
    public $bizDataList;

    /**
     * @var string[]
     */
    public $bizExtMap;

    /**
     * @var relationPermissionDTO
     */
    public $relationPermissionDTO;

    /**
     * @example ddsf3234234
     *
     * @var string
     */
    public $sourceDataId;
    protected $_name = [
        'bizDataList' => 'bizDataList',
        'bizExtMap' => 'bizExtMap',
        'relationPermissionDTO' => 'relationPermissionDTO',
        'sourceDataId' => 'sourceDataId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizDataList) {
            $res['bizDataList'] = [];
            if (null !== $this->bizDataList && \is_array($this->bizDataList)) {
                $n = 0;
                foreach ($this->bizDataList as $item) {
                    $res['bizDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizExtMap) {
            $res['bizExtMap'] = $this->bizExtMap;
        }
        if (null !== $this->relationPermissionDTO) {
            $res['relationPermissionDTO'] = null !== $this->relationPermissionDTO ? $this->relationPermissionDTO->toMap() : null;
        }
        if (null !== $this->sourceDataId) {
            $res['sourceDataId'] = $this->sourceDataId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relationList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizDataList'])) {
            if (!empty($map['bizDataList'])) {
                $model->bizDataList = [];
                $n = 0;
                foreach ($map['bizDataList'] as $item) {
                    $model->bizDataList[$n++] = null !== $item ? bizDataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizExtMap'])) {
            $model->bizExtMap = $map['bizExtMap'];
        }
        if (isset($map['relationPermissionDTO'])) {
            $model->relationPermissionDTO = relationPermissionDTO::fromMap($map['relationPermissionDTO']);
        }
        if (isset($map['sourceDataId'])) {
            $model->sourceDataId = $map['sourceDataId'];
        }

        return $model;
    }
}
