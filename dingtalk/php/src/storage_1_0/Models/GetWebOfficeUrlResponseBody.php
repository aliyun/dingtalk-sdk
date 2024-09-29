<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetWebOfficeUrlResponseBody extends Model
{
    /**
     * @var string
     */
    public $webOfficeAccessToken;

    /**
     * @var string
     */
    public $webOfficeRefreshToken;

    /**
     * @var string
     */
    public $webOfficeUrl;
    protected $_name = [
        'webOfficeAccessToken'  => 'webOfficeAccessToken',
        'webOfficeRefreshToken' => 'webOfficeRefreshToken',
        'webOfficeUrl'          => 'webOfficeUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->webOfficeAccessToken) {
            $res['webOfficeAccessToken'] = $this->webOfficeAccessToken;
        }
        if (null !== $this->webOfficeRefreshToken) {
            $res['webOfficeRefreshToken'] = $this->webOfficeRefreshToken;
        }
        if (null !== $this->webOfficeUrl) {
            $res['webOfficeUrl'] = $this->webOfficeUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWebOfficeUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['webOfficeAccessToken'])) {
            $model->webOfficeAccessToken = $map['webOfficeAccessToken'];
        }
        if (isset($map['webOfficeRefreshToken'])) {
            $model->webOfficeRefreshToken = $map['webOfficeRefreshToken'];
        }
        if (isset($map['webOfficeUrl'])) {
            $model->webOfficeUrl = $map['webOfficeUrl'];
        }

        return $model;
    }
}
