<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluTextToImageModelResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 0112_1222
     *
     * @var string
     */
    public $requestId;

    /**
     * @example 123
     *
     * @var string
     */
    public $taskId;

    /**
     * @example SUCCEEDED
     *
     * @var string
     */
    public $taskStatus;
    protected $_name = [
        'requestId'  => 'requestId',
        'taskId'     => 'taskId',
        'taskStatus' => 'taskStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }

        return $model;
    }
}
