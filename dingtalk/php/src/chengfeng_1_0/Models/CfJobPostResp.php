<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfJobPostResp extends Model
{
    /**
     * @description 职务编码
     *
     * @var string
     */
    public $jobPostCode;

    /**
     * @description 职务名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'jobPostCode' => 'jobPostCode',
        'name'        => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobPostCode) {
            $res['jobPostCode'] = $this->jobPostCode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CfJobPostResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobPostCode'])) {
            $model->jobPostCode = $map['jobPostCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
