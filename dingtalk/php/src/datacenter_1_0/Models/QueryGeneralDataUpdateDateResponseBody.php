<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGeneralDataUpdateDateResponseBody extends Model
{
    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $updateDate;
    protected $_name = [
        'success'    => 'success',
        'updateDate' => 'updateDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->updateDate) {
            $res['updateDate'] = $this->updateDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGeneralDataUpdateDateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['updateDate'])) {
            $model->updateDate = $map['updateDate'];
        }

        return $model;
    }
}
