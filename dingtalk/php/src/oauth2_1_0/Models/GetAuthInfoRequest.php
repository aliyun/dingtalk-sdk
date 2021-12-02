<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAuthInfoRequest extends Model
{
    /**
     * @var string
     */
    public $authCorpId;
    protected $_name = [
        'authCorpId' => 'authCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authCorpId) {
            $res['authCorpId'] = $this->authCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAuthInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authCorpId'])) {
            $model->authCorpId = $map['authCorpId'];
        }

        return $model;
    }
}
