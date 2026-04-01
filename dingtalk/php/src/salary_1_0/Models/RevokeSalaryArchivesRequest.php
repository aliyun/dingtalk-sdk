<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\Tea\Model;

class RevokeSalaryArchivesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2025-06-01
     *
     * @var string
     */
    public $effectiveDate;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'effectiveDate' => 'effectiveDate',
        'opUserId' => 'opUserId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->effectiveDate) {
            $res['effectiveDate'] = $this->effectiveDate;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RevokeSalaryArchivesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['effectiveDate'])) {
            $model->effectiveDate = $map['effectiveDate'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
