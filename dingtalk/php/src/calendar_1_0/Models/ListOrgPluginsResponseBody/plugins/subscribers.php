<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListOrgPluginsResponseBody\plugins;

use AlibabaCloud\Tea\Model;

class subscribers extends Model
{
    /**
     * @var string[]
     */
    public $deptIds;

    /**
     * @var string[]
     */
    public $unionIds;
    protected $_name = [
        'deptIds' => 'deptIds',
        'unionIds' => 'unionIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->unionIds) {
            $res['unionIds'] = $this->unionIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subscribers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['unionIds'])) {
            if (!empty($map['unionIds'])) {
                $model->unionIds = $map['unionIds'];
            }
        }

        return $model;
    }
}
