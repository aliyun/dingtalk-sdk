<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class qualificationInfos extends Model
{
    /**
     * @description 子机构行业资质图片
     *
     * @var string
     */
    public $qualificationImage;

    /**
     * @description 子机构行业资质类型
     *
     * @var string
     */
    public $qualificationType;
    protected $_name = [
        'qualificationImage' => 'qualificationImage',
        'qualificationType'  => 'qualificationType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->qualificationImage) {
            $res['qualificationImage'] = $this->qualificationImage;
        }
        if (null !== $this->qualificationType) {
            $res['qualificationType'] = $this->qualificationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return qualificationInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['qualificationImage'])) {
            $model->qualificationImage = $map['qualificationImage'];
        }
        if (isset($map['qualificationType'])) {
            $model->qualificationType = $map['qualificationType'];
        }

        return $model;
    }
}
