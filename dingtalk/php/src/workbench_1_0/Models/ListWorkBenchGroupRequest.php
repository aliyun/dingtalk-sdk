<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListWorkBenchGroupRequest extends Model
{
    /**
     * @var string
     */
    public $opUnionId;

    /**
     * @var string
     */
    public $ecologicalCorpId;

    /**
     * @var string
     */
    public $groupType;
    protected $_name = [
        'opUnionId'        => 'opUnionId',
        'ecologicalCorpId' => 'ecologicalCorpId',
        'groupType'        => 'groupType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }
        if (null !== $this->ecologicalCorpId) {
            $res['ecologicalCorpId'] = $this->ecologicalCorpId;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
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
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['ecologicalCorpId'])) {
            $model->ecologicalCorpId = $map['ecologicalCorpId'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }

        return $model;
    }
}
