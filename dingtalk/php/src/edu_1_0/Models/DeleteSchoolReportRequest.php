<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteSchoolReportRequest extends Model
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
     * @var string
     */
    public $teacherId;
    protected $_name = [
        'bizCode'        => 'bizCode',
        'schoolReportId' => 'schoolReportId',
        'teacherId'      => 'teacherId',
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
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteSchoolReportRequest
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
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }

        return $model;
    }
}
