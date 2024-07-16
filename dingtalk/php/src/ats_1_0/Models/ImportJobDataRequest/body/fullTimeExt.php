<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataRequest\body;

use AlibabaCloud\Tea\Model;

class fullTimeExt extends Model
{
    /**
     * @var int
     */
    public $salaryMonth;
    protected $_name = [
        'salaryMonth' => 'salaryMonth',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->salaryMonth) {
            $res['salaryMonth'] = $this->salaryMonth;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fullTimeExt
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['salaryMonth'])) {
            $model->salaryMonth = $map['salaryMonth'];
        }

        return $model;
    }
}
