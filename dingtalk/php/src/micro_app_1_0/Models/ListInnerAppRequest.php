<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListInnerAppRequest extends Model
{
    /**
     * @description 合作空间corpId
     *
     * @var string
     */
    public $ecologicalCorpId;
    protected $_name = [
        'ecologicalCorpId' => 'ecologicalCorpId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListInnerAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ecologicalCorpId'])) {
            $model->ecologicalCorpId = $map['ecologicalCorpId'];
        }

        return $model;
    }
}
