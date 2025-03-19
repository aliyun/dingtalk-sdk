<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SaveCustomWaterMarkTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example PROC-292988B1-5064-4A42-9389-A76B97xxxxx
     *
     * @var string
     */
    public $formCode;

    /**
     * @example PROC-292988B1-5064-4A42-9389-A76B97xxxxx
     *
     * @var string
     */
    public $waterMarkId;
    protected $_name = [
        'formCode' => 'formCode',
        'waterMarkId' => 'waterMarkId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->waterMarkId) {
            $res['waterMarkId'] = $this->waterMarkId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['waterMarkId'])) {
            $model->waterMarkId = $map['waterMarkId'];
        }

        return $model;
    }
}
