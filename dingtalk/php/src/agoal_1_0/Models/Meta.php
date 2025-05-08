<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class Meta extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $active;

    /**
     * @example 编码
     *
     * @var string
     */
    public $alias;

    /**
     * @example common
     *
     * @var string
     */
    public $category;

    /**
     * @example title
     *
     * @var string
     */
    public $code;

    /**
     * @example true
     *
     * @var bool
     */
    public $forceActive;

    /**
     * @example true
     *
     * @var bool
     */
    public $forceRequired;

    /**
     * @example true
     *
     * @var bool
     */
    public $required;

    /**
     * @example {"width": 200}
     *
     * @var mixed[]
     */
    public $scheme;

    /**
     * @example 名称
     *
     * @var string
     */
    public $title;

    /**
     * @example string
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'active' => 'active',
        'alias' => 'alias',
        'category' => 'category',
        'code' => 'code',
        'forceActive' => 'forceActive',
        'forceRequired' => 'forceRequired',
        'required' => 'required',
        'scheme' => 'scheme',
        'title' => 'title',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->alias) {
            $res['alias'] = $this->alias;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->forceActive) {
            $res['forceActive'] = $this->forceActive;
        }
        if (null !== $this->forceRequired) {
            $res['forceRequired'] = $this->forceRequired;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->scheme) {
            $res['scheme'] = $this->scheme;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return Meta
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['alias'])) {
            $model->alias = $map['alias'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['forceActive'])) {
            $model->forceActive = $map['forceActive'];
        }
        if (isset($map['forceRequired'])) {
            $model->forceRequired = $map['forceRequired'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['scheme'])) {
            $model->scheme = $map['scheme'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
