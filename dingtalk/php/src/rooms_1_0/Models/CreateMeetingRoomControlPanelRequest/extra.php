<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelRequest;

use AlibabaCloud\Tea\Model;

class extra extends Model
{
    /**
     * @var string[]
     */
    public $param;
    protected $_name = [
        'param' => 'param',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->param) {
            $res['param'] = $this->param;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extra
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['param'])) {
            $model->param = $map['param'];
        }

        return $model;
    }
}
