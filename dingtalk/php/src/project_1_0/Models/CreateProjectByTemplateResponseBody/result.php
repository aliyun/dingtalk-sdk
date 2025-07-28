<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectByTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-08-01T09:50:31.275Z
     *
     * @var string
     */
    public $created;

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
     * @example 62e7a1e721d20b5aexxx
     *
     * @var string
     */
    public $id;

    /**
     * @example https://www.xxx.com/xxxxx
     *
     * @var string
     */
    public $logo;

    /**
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
     * @example project
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'created' => 'created',
        'description' => 'description',
        'endDate' => 'endDate',
        'id' => 'id',
        'logo' => 'logo',
        'name' => 'name',
        'programId' => 'programId',
        'startDate' => 'startDate',
        'visibility' => 'visibility',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
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
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
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
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
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
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
