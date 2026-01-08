<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListConvNavTabResponseBody\result;

use AlibabaCloud\Tea\Model;

class convNavTabInfos extends Model
{
    /**
     * @var string
     */
    public $mobileUrl;

    /**
     * @var string
     */
    public $pcUrl;

    /**
     * @var string
     */
    public $tabId;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $type;

    /**
     * @var bool
     */
    public $userEditable;
    protected $_name = [
        'mobileUrl' => 'mobileUrl',
        'pcUrl' => 'pcUrl',
        'tabId' => 'tabId',
        'title' => 'title',
        'type' => 'type',
        'userEditable' => 'userEditable',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->tabId) {
            $res['tabId'] = $this->tabId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userEditable) {
            $res['userEditable'] = $this->userEditable;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return convNavTabInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['tabId'])) {
            $model->tabId = $map['tabId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userEditable'])) {
            $model->userEditable = $map['userEditable'];
        }

        return $model;
    }
}
