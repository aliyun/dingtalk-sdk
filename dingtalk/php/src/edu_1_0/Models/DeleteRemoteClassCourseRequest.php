<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRemoteClassCourseRequest extends Model
{
    /**
     * @description 免登码
     *
     * @var string
     */
    public $authCode;
    protected $_name = [
        'authCode' => 'authCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRemoteClassCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }

        return $model;
    }
}
