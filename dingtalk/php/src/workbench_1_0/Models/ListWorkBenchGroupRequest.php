<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListWorkBenchGroupRequest extends Model
{
    /**
     * @example corpId
     *
     * @var string
     */
    public $ecologicalCorpId;

    /**
     * @description This parameter is required.
     *
     * @example 首页 = WORK_HOME 全部页 = WORK_ALL_APP
     *
     * @var string
     */
    public $groupType;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $opUnionId;
    protected $_name = [
        'ecologicalCorpId' => 'ecologicalCorpId',
        'groupType'        => 'groupType',
        'opUnionId'        => 'opUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ecologicalCorpId) {
            $res['ecologicalCorpId'] = $this->ecologicalCorpId;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListWorkBenchGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ecologicalCorpId'])) {
            $model->ecologicalCorpId = $map['ecologicalCorpId'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }

        return $model;
    }
}
