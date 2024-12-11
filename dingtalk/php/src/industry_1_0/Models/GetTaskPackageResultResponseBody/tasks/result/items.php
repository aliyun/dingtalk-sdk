<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\GetTaskPackageResultResponseBody\tasks\result;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $advantages;

    /**
     * @var string
     */
    public $fabReference;

    /**
     * @var string
     */
    public $info;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $point;

    /**
     * @var string
     */
    public $reference;

    /**
     * @var bool
     */
    public $res;

    /**
     * @var string
     */
    public $suggestion;
    protected $_name = [
        'advantages'   => 'advantages',
        'fabReference' => 'fabReference',
        'info'         => 'info',
        'name'         => 'name',
        'point'        => 'point',
        'reference'    => 'reference',
        'res'          => 'res',
        'suggestion'   => 'suggestion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->advantages) {
            $res['advantages'] = $this->advantages;
        }
        if (null !== $this->fabReference) {
            $res['fabReference'] = $this->fabReference;
        }
        if (null !== $this->info) {
            $res['info'] = $this->info;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->point) {
            $res['point'] = $this->point;
        }
        if (null !== $this->reference) {
            $res['reference'] = $this->reference;
        }
        if (null !== $this->res) {
            $res['res'] = $this->res;
        }
        if (null !== $this->suggestion) {
            $res['suggestion'] = $this->suggestion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['advantages'])) {
            $model->advantages = $map['advantages'];
        }
        if (isset($map['fabReference'])) {
            $model->fabReference = $map['fabReference'];
        }
        if (isset($map['info'])) {
            $model->info = $map['info'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['point'])) {
            $model->point = $map['point'];
        }
        if (isset($map['reference'])) {
            $model->reference = $map['reference'];
        }
        if (isset($map['res'])) {
            $model->res = $map['res'];
        }
        if (isset($map['suggestion'])) {
            $model->suggestion = $map['suggestion'];
        }

        return $model;
    }
}
