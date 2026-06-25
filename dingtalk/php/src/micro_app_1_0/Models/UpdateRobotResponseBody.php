<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRobotResponseBody extends Model
{
    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $unifiedAppId;
    protected $_name = [
        'success' => 'success',
        'unifiedAppId' => 'unifiedAppId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->unifiedAppId) {
            $res['unifiedAppId'] = $this->unifiedAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRobotResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['unifiedAppId'])) {
            $model->unifiedAppId = $map['unifiedAppId'];
        }

        return $model;
    }
}
