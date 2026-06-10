<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecuteImportResponseBody extends Model
{
    /**
     * @var string
     */
    public $importId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'importId' => 'importId',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->importId) {
            $res['importId'] = $this->importId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteImportResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['importId'])) {
            $model->importId = $map['importId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
