<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteDirRequest extends Model
{
    /**
     * @example oaDirIdxxx
     *
     * @var string
     */
    public $dirId;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $operateUserId;
    protected $_name = [
        'dirId' => 'dirId',
        'operateUserId' => 'operateUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dirId) {
            $res['dirId'] = $this->dirId;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDirRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dirId'])) {
            $model->dirId = $map['dirId'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }

        return $model;
    }
}
