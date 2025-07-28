<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewResponseBody\events\extendedProperties;

use AlibabaCloud\Tea\Model;

class privateProperties extends Model
{
    /**
     * @var string
     */
    public $dingtalkDetailUrl;
    protected $_name = [
        'dingtalkDetailUrl' => 'dingtalkDetailUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingtalkDetailUrl) {
            $res['dingtalkDetailUrl'] = $this->dingtalkDetailUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return privateProperties
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingtalkDetailUrl'])) {
            $model->dingtalkDetailUrl = $map['dingtalkDetailUrl'];
        }

        return $model;
    }
}
