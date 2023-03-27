<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPositionResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 职责描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $establishDate;

    /**
     * @description 职位编码
     *
     * @var string
     */
    public $jobCode;

    /**
     * @description 任职要求
     *
     * @var string
     */
    public $jobRequirements;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 生效时间
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 失效时间
     *
     * @var string
     */
    public $stopDate;
    protected $_name = [
        'description'     => 'description',
        'establishDate'   => 'establishDate',
        'jobCode'         => 'jobCode',
        'jobRequirements' => 'jobRequirements',
        'name'            => 'name',
        'startDate'       => 'startDate',
        'stopDate'        => 'stopDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->establishDate) {
            $res['establishDate'] = $this->establishDate;
        }
        if (null !== $this->jobCode) {
            $res['jobCode'] = $this->jobCode;
        }
        if (null !== $this->jobRequirements) {
            $res['jobRequirements'] = $this->jobRequirements;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->stopDate) {
            $res['stopDate'] = $this->stopDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['establishDate'])) {
            $model->establishDate = $map['establishDate'];
        }
        if (isset($map['jobCode'])) {
            $model->jobCode = $map['jobCode'];
        }
        if (isset($map['jobRequirements'])) {
            $model->jobRequirements = $map['jobRequirements'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['stopDate'])) {
            $model->stopDate = $map['stopDate'];
        }

        return $model;
    }
}
