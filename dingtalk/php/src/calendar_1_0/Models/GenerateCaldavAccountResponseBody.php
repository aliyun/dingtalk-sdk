<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GenerateCaldavAccountResponseBody extends Model
{
    /**
     * @var string
     */
    public $serverAddress;

    /**
     * @var string
     */
    public $username;

    /**
     * @var string
     */
    public $password;
    protected $_name = [
        'serverAddress' => 'serverAddress',
        'username'      => 'username',
        'password'      => 'password',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->serverAddress) {
            $res['serverAddress'] = $this->serverAddress;
        }
        if (null !== $this->username) {
            $res['username'] = $this->username;
        }
        if (null !== $this->password) {
            $res['password'] = $this->password;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GenerateCaldavAccountResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['serverAddress'])) {
            $model->serverAddress = $map['serverAddress'];
        }
        if (isset($map['username'])) {
            $model->username = $map['username'];
        }
        if (isset($map['password'])) {
            $model->password = $map['password'];
        }

        return $model;
    }
}
