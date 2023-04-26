<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveIntegratedInstanceRequest\formComponentValueList;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveIntegratedInstanceRequest\notifiers;
use AlibabaCloud\Tea\Model;

class SaveIntegratedInstanceRequest extends Model
{
    /**
     * @var formComponentValueList[]
     */
    public $formComponentValueList;

    /**
     * @var notifiers[]
     */
    public $notifiers;

    /**
     * @var string
     */
    public $originatorUserId;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $title;

    /**
     * @example https://www.dingtalk.com/
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'formComponentValueList' => 'formComponentValueList',
        'notifiers'              => 'notifiers',
        'originatorUserId'       => 'originatorUserId',
        'processCode'            => 'processCode',
        'title'                  => 'title',
        'url'                    => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formComponentValueList) {
            $res['formComponentValueList'] = [];
            if (null !== $this->formComponentValueList && \is_array($this->formComponentValueList)) {
                $n = 0;
                foreach ($this->formComponentValueList as $item) {
                    $res['formComponentValueList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->notifiers) {
            $res['notifiers'] = [];
            if (null !== $this->notifiers && \is_array($this->notifiers)) {
                $n = 0;
                foreach ($this->notifiers as $item) {
                    $res['notifiers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->originatorUserId) {
            $res['originatorUserId'] = $this->originatorUserId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveIntegratedInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formComponentValueList'])) {
            if (!empty($map['formComponentValueList'])) {
                $model->formComponentValueList = [];
                $n                             = 0;
                foreach ($map['formComponentValueList'] as $item) {
                    $model->formComponentValueList[$n++] = null !== $item ? formComponentValueList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['notifiers'])) {
            if (!empty($map['notifiers'])) {
                $model->notifiers = [];
                $n                = 0;
                foreach ($map['notifiers'] as $item) {
                    $model->notifiers[$n++] = null !== $item ? notifiers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['originatorUserId'])) {
            $model->originatorUserId = $map['originatorUserId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
