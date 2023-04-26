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
