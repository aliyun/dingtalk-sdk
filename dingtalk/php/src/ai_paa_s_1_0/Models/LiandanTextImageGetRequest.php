<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class LiandanTextImageGetRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example IMAGE
     *
     * @var string
     */
    public $module;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $taskId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'module' => 'module',
        'taskId' => 'taskId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LiandanTextImageGetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
