<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList\bizDataList;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList\relationPermissionDTO;
use AlibabaCloud\Tea\Model;

class relationList extends Model
{
    /**
     * @description 关系模型数据。
     *
     * @var bizDataList[]
     */
    public $bizDataList;

    /**
     * @description 扩展业务字段。
     *
     * @var string[]
     */
    public $bizExtMap;

    /**
     * @description 负责人、协同人信息。
     *
     * @var relationPermissionDTO
     */
    public $relationPermissionDTO;
    protected $_name = [
        'bizDataList'           => 'bizDataList',
        'bizExtMap'             => 'bizExtMap',
        'relationPermissionDTO' => 'relationPermissionDTO',
    ];

    public function validate()
    {
    }

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
                $n                  = 0;
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

        return $model;
    }
}
