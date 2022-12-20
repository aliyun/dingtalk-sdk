<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddLeadsResponseBody extends Model
{
    /**
     * @var string
     */
    public $outTaskId;
    protected $_name = [
        'outTaskId' => 'outTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outTaskId) {
            $res['outTaskId'] = $this->outTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddLeadsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outTaskId'])) {
            $model->outTaskId = $map['outTaskId'];
        }

        return $model;
    }
}
