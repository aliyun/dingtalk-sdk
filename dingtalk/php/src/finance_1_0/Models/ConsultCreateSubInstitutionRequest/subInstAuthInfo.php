<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class subInstAuthInfo extends Model
{
    /**
     * @description 授权函图片url
     *
     * @var string
     */
    public $authorizationLetterUrl;
    protected $_name = [
        'authorizationLetterUrl' => 'authorizationLetterUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorizationLetterUrl) {
            $res['authorizationLetterUrl'] = $this->authorizationLetterUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subInstAuthInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorizationLetterUrl'])) {
            $model->authorizationLetterUrl = $map['authorizationLetterUrl'];
        }

        return $model;
    }
}
