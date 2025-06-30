<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateProjectByTemplateRequest extends Model
{
    /**
     * @example 这是项目描述
     *
     * @var string
     */
    public $description;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $endDate;

    /**
     * @description This parameter is required.
     *
     * @example 项目1
     *
     * @var string
     */
    public $name;

    /**
     * @example 578cae9dbf83e5xxxx
     *
     * @var string
     */
    public $programId;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @description This parameter is required.
     *
     * @example 578cae9dbf83e5xxxx
     *
     * @var string
     */
    public $templateId;

    /**
     * @example project
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'description' => 'description',
        'endDate' => 'endDate',
        'name' => 'name',
        'programId' => 'programId',
        'startDate' => 'startDate',
        'templateId' => 'templateId',
        'visibility' => 'visibility',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->programId) {
            $res['programId'] = $this->programId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateProjectByTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['programId'])) {
            $model->programId = $map['programId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
