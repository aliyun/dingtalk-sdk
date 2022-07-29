<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\GetFormInstanceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\GetFormInstanceResponseBody\result\forms;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建时间。iso8601格式。
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建者userid
     *
     * @var string
     */
    public $creator;

    /**
     * @description 填表code，用此code可调接口获取填表实例列表。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单内容列表。
     *
     * @var forms[]
     */
    public $forms;

    /**
     * @description 更新时间。iso8601格式。
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @description 填表名称。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'createTime' => 'createTime',
        'creator'    => 'creator',
        'formCode'   => 'formCode',
        'forms'      => 'forms',
        'modifyTime' => 'modifyTime',
        'title'      => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->forms) {
            $res['forms'] = [];
            if (null !== $this->forms && \is_array($this->forms)) {
                $n = 0;
                foreach ($this->forms as $item) {
                    $res['forms'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['forms'])) {
            if (!empty($map['forms'])) {
                $model->forms = [];
                $n            = 0;
                foreach ($map['forms'] as $item) {
                    $model->forms[$n++] = null !== $item ? forms::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
