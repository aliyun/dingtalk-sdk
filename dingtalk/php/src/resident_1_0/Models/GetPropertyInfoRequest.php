<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPropertyInfoRequest extends Model
{
    /**
     * @description dingCropId
     *
     * @var string
     */
    public $propertyCorpId;
    protected $_name = [
        'propertyCorpId' => 'propertyCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->propertyCorpId) {
            $res['propertyCorpId'] = $this->propertyCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPropertyInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['propertyCorpId'])) {
            $model->propertyCorpId = $map['propertyCorpId'];
        }

        return $model;
    }
}
