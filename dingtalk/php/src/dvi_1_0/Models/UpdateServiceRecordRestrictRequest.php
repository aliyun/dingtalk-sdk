<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateServiceRecordRestrictRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $recordIds;
    protected $_name = [
        'action' => 'action',
        'recordIds' => 'recordIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->recordIds) {
            $res['recordIds'] = $this->recordIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateServiceRecordRestrictRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['recordIds'])) {
            if (!empty($map['recordIds'])) {
                $model->recordIds = $map['recordIds'];
            }
        }

        return $model;
    }
}
