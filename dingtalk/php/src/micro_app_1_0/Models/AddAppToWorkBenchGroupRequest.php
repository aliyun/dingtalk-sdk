<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddAppToWorkBenchGroupRequest extends Model
{
    /**
     * @description 创建人unionId
     *
     * @var string
     */
    public $opUnionId;

    /**
     * @description 关联组织corpId
     *
     * @var string
     */
    public $ecologicalCorpId;

    /**
     * @description 工作台分组id
     *
     * @var string
     */
    public $componentId;
    protected $_name = [
        'opUnionId'        => 'opUnionId',
        'ecologicalCorpId' => 'ecologicalCorpId',
        'componentId'      => 'componentId',
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
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
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
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['ecologicalCorpId'])) {
            $model->ecologicalCorpId = $map['ecologicalCorpId'];
        }
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }

        return $model;
    }
}
