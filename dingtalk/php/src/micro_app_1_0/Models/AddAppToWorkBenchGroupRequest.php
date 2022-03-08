<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddAppToWorkBenchGroupRequest extends Model
{
    /**
     * @description 工作台分组id
     *
     * @var string
     */
    public $componentId;

    /**
     * @description 关联组织corpId
     *
     * @var string
     */
    public $ecologicalCorpId;

    /**
     * @description 创建人unionId
     *
     * @var string
     */
    public $opUnionId;
    protected $_name = [
        'componentId'      => 'componentId',
        'ecologicalCorpId' => 'ecologicalCorpId',
        'opUnionId'        => 'opUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }
        if (null !== $this->ecologicalCorpId) {
            $res['ecologicalCorpId'] = $this->ecologicalCorpId;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddAppToWorkBenchGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }
        if (isset($map['ecologicalCorpId'])) {
            $model->ecologicalCorpId = $map['ecologicalCorpId'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }

        return $model;
    }
}
