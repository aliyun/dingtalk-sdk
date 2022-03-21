<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConvertLegacyEventIdRequest extends Model
{
    /**
     * @var string[]
     */
    public $legacyEventIds;
    protected $_name = [
        'legacyEventIds' => 'legacyEventIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->legacyEventIds) {
            $res['legacyEventIds'] = $this->legacyEventIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConvertLegacyEventIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['legacyEventIds'])) {
            if (!empty($map['legacyEventIds'])) {
                $model->legacyEventIds = $map['legacyEventIds'];
            }
        }

        return $model;
    }
}
