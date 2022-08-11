<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $created;

    /**
     * @description 模板描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 模板id
     *
     * @var string
     */
    public $id;

    /**
     * @description 是否已删除
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 是否demo模板
     *
     * @var bool
     */
    public $isDemo;

    /**
     * @description 模板log地址
     *
     * @var string
     */
    public $logo;

    /**
     * @description 模板名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 更新时间
     *
     * @var string
     */
    public $updated;

    /**
     * @description 模板可见性。organization 或者 involves
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'created'     => 'created',
        'description' => 'description',
        'id'          => 'id',
        'isDeleted'   => 'isDeleted',
        'isDemo'      => 'isDemo',
        'logo'        => 'logo',
        'name'        => 'name',
        'updated'     => 'updated',
        'visible'     => 'visible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->isDemo) {
            $res['isDemo'] = $this->isDemo;
        }
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['isDemo'])) {
            $model->isDemo = $map['isDemo'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
