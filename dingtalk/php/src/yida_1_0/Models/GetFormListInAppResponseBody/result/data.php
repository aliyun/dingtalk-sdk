<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormListInAppResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormListInAppResponseBody\result\data\title;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $creator;

    /**
     * @var string
     */
    public $formType;

    /**
     * @var string
     */
    public $formUuid;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var title
     */
    public $title;
    protected $_name = [
        'creator'   => 'creator',
        'formType'  => 'formType',
        'formUuid'  => 'formUuid',
        'gmtCreate' => 'gmtCreate',
        'title'     => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->formType) {
            $res['formType'] = $this->formType;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->title) {
            $res['title'] = null !== $this->title ? $this->title->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['formType'])) {
            $model->formType = $map['formType'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['title'])) {
            $model->title = title::fromMap($map['title']);
        }

        return $model;
    }
}
