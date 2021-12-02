<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSsoAccessTokenRequest extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpid;

    /**
     * @description sso密码
     *
     * @var string
     */
    public $ssoSecret;
    protected $_name = [
        'corpid'    => 'corpid',
        'ssoSecret' => 'ssoSecret',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpid) {
            $res['corpid'] = $this->corpid;
        }
        if (null !== $this->ssoSecret) {
            $res['ssoSecret'] = $this->ssoSecret;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSsoAccessTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpid'])) {
            $model->corpid = $map['corpid'];
        }
        if (isset($map['ssoSecret'])) {
            $model->ssoSecret = $map['ssoSecret'];
        }

        return $model;
    }
}
