<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content;

use AlibabaCloud\Tea\Model;

class jobStatus extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $statusName;
    protected $_name = [
        'code'       => 'code',
        'statusName' => 'statusName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->statusName) {
            $res['statusName'] = $this->statusName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return jobStatus
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['statusName'])) {
            $model->statusName = $map['statusName'];
        }

        return $model;
    }
}
