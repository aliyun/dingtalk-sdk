<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsResponseBody\result;

use AlibabaCloud\Tea\Model;

class openHonors extends Model
{
    /**
     * @description 荣誉含义
     *
     * @var string
     */
    public $honorDesc;

    /**
     * @description 荣誉id
     *
     * @var int
     */
    public $honorId;

    /**
     * @description 荣誉图片url
     *
     * @var string
     */
    public $honorImgUrl;

    /**
     * @description 荣誉名字
     *
     * @var string
     */
    public $honorName;

    /**
     * @description 荣誉附赠的挂件图url
     *
     * @var string
     */
    public $honorPendantImgUrl;
    protected $_name = [
        'honorDesc'          => 'honorDesc',
        'honorId'            => 'honorId',
        'honorImgUrl'        => 'honorImgUrl',
        'honorName'          => 'honorName',
        'honorPendantImgUrl' => 'honorPendantImgUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->honorDesc) {
            $res['honorDesc'] = $this->honorDesc;
        }
        if (null !== $this->honorId) {
            $res['honorId'] = $this->honorId;
        }
        if (null !== $this->honorImgUrl) {
            $res['honorImgUrl'] = $this->honorImgUrl;
        }
        if (null !== $this->honorName) {
            $res['honorName'] = $this->honorName;
        }
        if (null !== $this->honorPendantImgUrl) {
            $res['honorPendantImgUrl'] = $this->honorPendantImgUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openHonors
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['honorDesc'])) {
            $model->honorDesc = $map['honorDesc'];
        }
        if (isset($map['honorId'])) {
            $model->honorId = $map['honorId'];
        }
        if (isset($map['honorImgUrl'])) {
            $model->honorImgUrl = $map['honorImgUrl'];
        }
        if (isset($map['honorName'])) {
            $model->honorName = $map['honorName'];
        }
        if (isset($map['honorPendantImgUrl'])) {
            $model->honorPendantImgUrl = $map['honorPendantImgUrl'];
        }

        return $model;
    }
}
