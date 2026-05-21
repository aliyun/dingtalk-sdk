<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCustomRobotOutgoingResponseBody extends Model
{
    /**
     * @var string
     */
    public $originalUrl;

    /**
     * @var bool
     */
    public $result;

    /**
     * @var string
     */
    public $targetUrl;
    protected $_name = [
        'originalUrl' => 'originalUrl',
        'result' => 'result',
        'targetUrl' => 'targetUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->originalUrl) {
            $res['originalUrl'] = $this->originalUrl;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->targetUrl) {
            $res['targetUrl'] = $this->targetUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCustomRobotOutgoingResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['originalUrl'])) {
            $model->originalUrl = $map['originalUrl'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['targetUrl'])) {
            $model->targetUrl = $map['targetUrl'];
        }

        return $model;
    }
}
