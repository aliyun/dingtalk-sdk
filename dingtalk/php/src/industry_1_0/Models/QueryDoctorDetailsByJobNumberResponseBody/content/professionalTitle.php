<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content;

use AlibabaCloud\Tea\Model;

class professionalTitle extends Model
{
    /**
     * @description 职称编码
     *
     * @var string
     */
    public $code;

    /**
     * @description 职称大类
     *
     * @var string
     */
    public $professionalTitleCategory;

    /**
     * @description 职称明细
     *
     * @var string
     */
    public $professionalTitleDetail;
    protected $_name = [
        'code'                      => 'code',
        'professionalTitleCategory' => 'professionalTitleCategory',
        'professionalTitleDetail'   => 'professionalTitleDetail',
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
        if (null !== $this->professionalTitleCategory) {
            $res['professionalTitleCategory'] = $this->professionalTitleCategory;
        }
        if (null !== $this->professionalTitleDetail) {
            $res['professionalTitleDetail'] = $this->professionalTitleDetail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return professionalTitle
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['professionalTitleCategory'])) {
            $model->professionalTitleCategory = $map['professionalTitleCategory'];
        }
        if (isset($map['professionalTitleDetail'])) {
            $model->professionalTitleDetail = $map['professionalTitleDetail'];
        }

        return $model;
    }
}
