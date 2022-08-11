<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectByTemplateResponseBody;

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
     * @description 项目ID
     *
     * @var string
     */
    public $id;

    /**
     * @description 项目图标地址
     *
     * @var string
     */
    public $logo;

    /**
     * @description 项目名字
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'created' => 'created',
        'id'      => 'id',
        'logo'    => 'logo',
        'name'    => 'name',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
