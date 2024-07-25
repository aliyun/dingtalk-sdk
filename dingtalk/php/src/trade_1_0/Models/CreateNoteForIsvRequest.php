<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateNoteForIsvRequest extends Model
{
    /**
     * @var string
     */
    public $contactName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contactPhoneNum;

    /**
     * @var string
     */
    public $contactTitle;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $inputPhoneNum;
    protected $_name = [
        'contactName'     => 'contactName',
        'contactPhoneNum' => 'contactPhoneNum',
        'contactTitle'    => 'contactTitle',
        'content'         => 'content',
        'corpId'          => 'corpId',
        'inputPhoneNum'   => 'inputPhoneNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactName) {
            $res['contactName'] = $this->contactName;
        }
        if (null !== $this->contactPhoneNum) {
            $res['contactPhoneNum'] = $this->contactPhoneNum;
        }
        if (null !== $this->contactTitle) {
            $res['contactTitle'] = $this->contactTitle;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->inputPhoneNum) {
            $res['inputPhoneNum'] = $this->inputPhoneNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateNoteForIsvRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactName'])) {
            $model->contactName = $map['contactName'];
        }
        if (isset($map['contactPhoneNum'])) {
            $model->contactPhoneNum = $map['contactPhoneNum'];
        }
        if (isset($map['contactTitle'])) {
            $model->contactTitle = $map['contactTitle'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['inputPhoneNum'])) {
            $model->inputPhoneNum = $map['inputPhoneNum'];
        }

        return $model;
    }
}
