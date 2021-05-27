<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInnerAppRequest extends Model
{
    /**
     * @description 操作人unionId
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
    protected $_name = [
        'opUnionId'        => 'opUnionId',
        'ecologicalCorpId' => 'ecologicalCorpId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInnerAppRequest
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

        return $model;
    }
}
