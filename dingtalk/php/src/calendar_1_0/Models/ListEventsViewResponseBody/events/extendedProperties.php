<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewResponseBody\events;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewResponseBody\events\extendedProperties\privateProperties;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewResponseBody\events\extendedProperties\sharedProperties;
use AlibabaCloud\Tea\Model;

class extendedProperties extends Model
{
    /**
     * @var privateProperties
     */
    public $privateProperties;

    /**
     * @var sharedProperties
     */
    public $sharedProperties;
    protected $_name = [
        'privateProperties' => 'privateProperties',
        'sharedProperties'  => 'sharedProperties',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->privateProperties) {
            $res['privateProperties'] = null !== $this->privateProperties ? $this->privateProperties->toMap() : null;
        }
        if (null !== $this->sharedProperties) {
            $res['sharedProperties'] = null !== $this->sharedProperties ? $this->sharedProperties->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extendedProperties
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['privateProperties'])) {
            $model->privateProperties = privateProperties::fromMap($map['privateProperties']);
        }
        if (isset($map['sharedProperties'])) {
            $model->sharedProperties = sharedProperties::fromMap($map['sharedProperties']);
        }

        return $model;
    }
}
