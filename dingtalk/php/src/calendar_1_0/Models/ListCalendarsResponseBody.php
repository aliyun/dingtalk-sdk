<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsResponseBody\response;
use AlibabaCloud\Tea\Model;

class ListCalendarsResponseBody extends Model
{
    /**
     * @description 日历信息
     *
     * @var response
     */
    public $response;
    protected $_name = [
        'response' => 'response',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->response) {
            $res['response'] = null !== $this->response ? $this->response->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListCalendarsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['response'])) {
            $model->response = response::fromMap($map['response']);
        }

        return $model;
    }
}
