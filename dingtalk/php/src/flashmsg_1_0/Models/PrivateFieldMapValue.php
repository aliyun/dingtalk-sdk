<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrivateFieldMapValue extends Model
{
    /**
     * @example XXX发了一条闪读消息，请于今天 12:00前查看
     *
     * @var string
     */
    public $tipTitle;

    /**
     * @var bool
     */
    public $isDingSend;

    /**
     * @var bool
     */
    public $isRead;

    /**
     * @var string
     */
    public $buttonStatus;

    /**
     * @var string[]
     */
    public $extension;
    protected $_name = [
        'tipTitle' => 'tipTitle',
        'isDingSend' => 'isDingSend',
        'isRead' => 'isRead',
        'buttonStatus' => 'buttonStatus',
        'extension' => 'extension',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tipTitle) {
            $res['tipTitle'] = $this->tipTitle;
        }
        if (null !== $this->isDingSend) {
            $res['isDingSend'] = $this->isDingSend;
        }
        if (null !== $this->isRead) {
            $res['isRead'] = $this->isRead;
        }
        if (null !== $this->buttonStatus) {
            $res['buttonStatus'] = $this->buttonStatus;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrivateFieldMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tipTitle'])) {
            $model->tipTitle = $map['tipTitle'];
        }
        if (isset($map['isDingSend'])) {
            $model->isDingSend = $map['isDingSend'];
        }
        if (isset($map['isRead'])) {
            $model->isRead = $map['isRead'];
        }
        if (isset($map['buttonStatus'])) {
            $model->buttonStatus = $map['buttonStatus'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }

        return $model;
    }
}
