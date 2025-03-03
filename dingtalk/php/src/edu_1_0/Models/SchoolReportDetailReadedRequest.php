<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SchoolReportDetailReadedRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $schoolReportId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $studentIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'        => 'bizCode',
        'schoolReportId' => 'schoolReportId',
        'studentIds'     => 'studentIds',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->schoolReportId) {
            $res['schoolReportId'] = $this->schoolReportId;
        }
        if (null !== $this->studentIds) {
            $res['studentIds'] = $this->studentIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SchoolReportDetailReadedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['schoolReportId'])) {
            $model->schoolReportId = $map['schoolReportId'];
        }
        if (isset($map['studentIds'])) {
            if (!empty($map['studentIds'])) {
                $model->studentIds = $map['studentIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
