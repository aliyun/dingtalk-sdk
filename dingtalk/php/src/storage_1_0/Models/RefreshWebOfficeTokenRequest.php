<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class RefreshWebOfficeTokenRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $unionId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $webOfficeAccessToken;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $webOfficeRefreshToken;
    protected $_name = [
        'unionId' => 'unionId',
        'webOfficeAccessToken' => 'webOfficeAccessToken',
        'webOfficeRefreshToken' => 'webOfficeRefreshToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->webOfficeAccessToken) {
            $res['webOfficeAccessToken'] = $this->webOfficeAccessToken;
        }
        if (null !== $this->webOfficeRefreshToken) {
            $res['webOfficeRefreshToken'] = $this->webOfficeRefreshToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RefreshWebOfficeTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['webOfficeAccessToken'])) {
            $model->webOfficeAccessToken = $map['webOfficeAccessToken'];
        }
        if (isset($map['webOfficeRefreshToken'])) {
            $model->webOfficeRefreshToken = $map['webOfficeRefreshToken'];
        }

        return $model;
    }
}
