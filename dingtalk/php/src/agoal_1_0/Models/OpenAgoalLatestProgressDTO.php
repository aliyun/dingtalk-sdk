<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalLatestProgressDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1716952481672
     *
     * @var int
     */
    public $created;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $creator;

    /**
     * @description This parameter is required.
     *
     * @example <article class=\"4ever-article\"><p style=\"text-align:left;text-indent:0;margin-left:0;margin-top:0;margin-bottom:0\"><span>xxx</span></p></article>
     *
     * @var string
     */
    public $htmldescription;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $progressId;
    protected $_name = [
        'created' => 'created',
        'creator' => 'creator',
        'htmldescription' => 'htmldescription',
        'progressId' => 'progressId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->htmldescription) {
            $res['htmldescription'] = $this->htmldescription;
        }
        if (null !== $this->progressId) {
            $res['progressId'] = $this->progressId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalLatestProgressDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creator'])) {
            $model->creator = OpenAgoalUserDTO::fromMap($map['creator']);
        }
        if (isset($map['htmldescription'])) {
            $model->htmldescription = $map['htmldescription'];
        }
        if (isset($map['progressId'])) {
            $model->progressId = $map['progressId'];
        }

        return $model;
    }
}
