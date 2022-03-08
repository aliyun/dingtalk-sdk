<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponseBody\result;

use AlibabaCloud\Tea\Model;

class holidays extends Model
{
    /**
     * @description 假期名称
     *
     * @var string
     */
    public $holidayName;

    /**
     * @description 假期类型，festival：法定节假日；rest：调休日；overtime：加班日；
     *
     * @var string
     */
    public $holidayType;

    /**
     * @description 补休日，只有假期类型为加班日时才有值
     *
     * @var int
     */
    public $realWorkDate;

    /**
     * @description 日期
     *
     * @var int
     */
    public $workDate;
    protected $_name = [
        'holidayName'  => 'holidayName',
        'holidayType'  => 'holidayType',
        'realWorkDate' => 'realWorkDate',
        'workDate'     => 'workDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->holidayName) {
            $res['holidayName'] = $this->holidayName;
        }
        if (null !== $this->holidayType) {
            $res['holidayType'] = $this->holidayType;
        }
        if (null !== $this->realWorkDate) {
            $res['realWorkDate'] = $this->realWorkDate;
        }
        if (null !== $this->workDate) {
            $res['workDate'] = $this->workDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return holidays
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['holidayName'])) {
            $model->holidayName = $map['holidayName'];
        }
        if (isset($map['holidayType'])) {
            $model->holidayType = $map['holidayType'];
        }
        if (isset($map['realWorkDate'])) {
            $model->realWorkDate = $map['realWorkDate'];
        }
        if (isset($map['workDate'])) {
            $model->workDate = $map['workDate'];
        }

        return $model;
    }
}
