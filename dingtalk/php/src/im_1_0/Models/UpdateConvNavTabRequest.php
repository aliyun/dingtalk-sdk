<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateConvNavTabRequest extends Model
{
    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @example cidc4iLyQBuHFQRvzxznz204Q
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @example 409021
     *
     * @var string
     */
    public $tabId;

    /**
     * @example 示例标签页
     *
     * @var string
     */
    public $title;

    /**
     * @var bool
     */
    public $userEditable;
    protected $_name = [
        'mobileUrl' => 'mobileUrl',
        'openConversationId' => 'openConversationId',
        'pcUrl' => 'pcUrl',
        'tabId' => 'tabId',
        'title' => 'title',
        'userEditable' => 'userEditable',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
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
        if (null !== $this->userEditable) {
            $res['userEditable'] = $this->userEditable;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateConvNavTabRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
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
        if (isset($map['userEditable'])) {
            $model->userEditable = $map['userEditable'];
        }

        return $model;
    }
}
