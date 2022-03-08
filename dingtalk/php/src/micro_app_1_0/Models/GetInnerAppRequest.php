<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInnerAppRequest extends Model
{
    /**
     * @description 关联组织corpId
     *
     * @var string
     */
    public $ecologicalCorpId;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $opUnionId;
    protected $_name = [
        'ecologicalCorpId' => 'ecologicalCorpId',
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
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
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
        if (isset($map['ecologicalCorpId'])) {
            $model->ecologicalCorpId = $map['ecologicalCorpId'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }

        return $model;
    }
}
