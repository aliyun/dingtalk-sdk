<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConvertLegacyEventIdResponseBody extends Model
{
    /**
     * @description legacyEventIdMap
     *
     * @var mixed[]
     */
    public $legacyEventIdMap;
    protected $_name = [
        'legacyEventIdMap' => 'legacyEventIdMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->legacyEventIdMap) {
            $res['legacyEventIdMap'] = $this->legacyEventIdMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConvertLegacyEventIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['legacyEventIdMap'])) {
            $model->legacyEventIdMap = $map['legacyEventIdMap'];
        }

        return $model;
    }
}
