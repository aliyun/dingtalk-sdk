<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class RespondEventRequest extends Model
{
    /**
     * @var string
     */
    public $responseStatus;
    protected $_name = [
        'responseStatus' => 'responseStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->responseStatus) {
            $res['responseStatus'] = $this->responseStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RespondEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['responseStatus'])) {
            $model->responseStatus = $map['responseStatus'];
        }

        return $model;
    }
}
